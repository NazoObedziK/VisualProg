using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
   
    public partial class Form1 : Form
    {
        public Pen myPen = new Pen(Color.Black);
        public Pen pointCol = new Pen(Color.Red);
        public Graphics graphics = null;
        public List<Point> points=new List<Point>();
        private int pointSize = 3;
        private Point newPoint;

        private int xOffset;
        private int yOffset;
        //список для усіх утвр трикутн
        public List<List<Point>> trianglesList=new List<List<Point>>();
        //наші трикутники, що не містять точок всередині, і які ми виводимо і рисуємо
        public List<List<Point>> trianglesWithoutPoints = new List<List<Point>>();
        //список лейблів для надписів над точками 
        //окей, їх буде 10, якщо більше точок - програмі важко рахувати/малювати, тому 
        //можуть виникнути проблеми з програмою, якщо побудовано більше 10 точок, тоді графік не виведеться, лише точки, що утворюють трикутники
        public List<Label> marks;
		
        private int index = 0;
 
       
        
        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            myPen.Width = 1;
            pointCol.Width = 3;
            //задаємо власне ті 10 лейблів
            marks = new List<Label>() { mark1, mark2, mark3,mark4,mark5,mark6,mark7,mark8,mark9,mark10 };
            index = 0;
           
        }

        private void Paint(object sender, PaintEventArgs e)
        {
            
             
        }
        //додавання нової точки на нашу панель
        private void AddPoint(object sender, EventArgs e)
        {
            xOffset = Location.X + canvas.Location.X + 12;
            yOffset = Location.Y + canvas.Location.Y + 35;
            //додаємо точку біля курсора,  xOffset і  уOffset потрібі, щоб вище точки поставити лейбл з її координатами
            newPoint = new Point(Cursor.Position.X-xOffset,Cursor.Position.Y -yOffset );
            points.Add(newPoint);
            //додаємо лейбл з позицією над точкою 
            MarkPoint(newPoint);

            ShowPoints();
          

        }   
       
       //побудова ліній , з яких з'єднаються трикутники
       //будуємо всеможливі лінії з усеможливих наборів точок по 2
        public void ConnectAllPoints(List<Point> points)
        {
            //логічно, що для побудови лінії нам треба мати більше,ніж дві точки
            if (points.Count >= 2)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
					for (int j = 0; j < points.Count; j++)
					{
                        //власне рисування лінії
						graphics.DrawLine(myPen, points[i], points[j]);
					}
                }
            }
        }
      //генерування точок рандомом (в нас є відповідна кнопка)
        public void GeneratePoints(List<Point>points,int numOfPoints)
        {
            Random rand = new Random();
            for (int i = 0; i < numOfPoints; i++)
            {
                int randX = rand.Next(canvas.Location.X, canvas.Location.X + canvas.Width - 140);
                int randY = rand.Next(canvas.Location.Y - 50, canvas.Location.Y + canvas.Height - 60);
                points.Add(new Point(randX, randY));
            }
            
        }

        public void ShowPoints()
        {
            for (int i = 0; i < points.Count; i++)
            {
                graphics.DrawEllipse(pointCol, points[i].X, points[i].Y, pointSize, pointSize);
            }
        }
        //генерування точок+ лейбли над ними з підписами позицій
        private void GeneratePoints(object sender, EventArgs e)
        {
            GeneratePoints(points, Int32.Parse(NumOfPoints.Text));
            ShowPoints();
            for (int i = 0; i < points.Count; i++)
            {
                MarkPoint(points[i]);
                if (index>marks.Count)
                {
                    
                    break;
                }
            }
        }

        private void ClearCanvas(object sender, EventArgs e)
        {  // по суті, для очищення панелі видаляємо точки з допом методу RemoveRange,де 0- індекс,з якого починаємо видаляти
            //і оці всі каунти- кількість точок ,яку треба видалити
            //тобто ми просто очищаємо всі створені нами вище списки
            points.RemoveRange(0,points.Count);
            trianglesList.RemoveRange(0,trianglesList.Count);
            trianglesWithoutPoints.RemoveRange(0, trianglesWithoutPoints.Count);
            pointInside.Text = "";

            for (int i = 0; i < marks.Count; i++)
            {
                //очищаємо текст з лейблів над точками( де пише їх розташування)
                marks[i].Text = "";
            }
            index = 0;
            //очищаємо сам елемент graphics
            graphics.Clear(Color.White);
        }
        //це не зовсім алгоритм тріангуляції ,але деякі функції звідти можна взяти
        private void MakeTriangulation(object sender, EventArgs e)
        {//створюєм/додаєм список всеможливих трикутників
            AddAllTrianglesToTheList();
 
            test.Text = trianglesList.Count.ToString();
            //якщо точок тільки три, це автоматоматично трикутник без точок всередині
            if (points.Count==3)
            {
                trianglesWithoutPoints.Add(points);
            }
            else
            {
                for (int i = 0; i < points.Count; i++)
                {//інакше викликаємо функцію для відбору трикутників, всередині яких точок немає
                    TrianglesWithoutPointInside(points[i]);
                }
               
            }
            for (int i = 0; i < trianglesWithoutPoints.Count; i++)
            {//тут для всіх знайдених трикутників виводяться точки,на яких вони побудовані в нашому RichTextBox pointInside
                for (int j = 0; j < 3; j++)
                { 
                    pointInside.Text += trianglesWithoutPoints[i][j] + "\n";
                }
                pointInside.Text += "\n";
            }

            //з'єднуємо лінії для побудови трикутників
            ConnectAllPoints(points);

        }
        //якщо точка не всередині котрогось з трикутників, трикутник додається до списку трикутників без точок всередині
        public void AllTriangles(List<Point> pointsIn)
        {
            for (int i = 0; i < trianglesList.Count; i++)
            {
                for (int j = 0; j < trianglesList[i].Count; j++)
                {
                    for (int k = 0; k < pointsIn.Count; k++)
                    {
                        if (pointsIn[k] != trianglesList[i][j])
                        {
                            trianglesWithoutPoints.Add(trianglesList[i]);
                        }
                    }
                   
                }
                
            }
        }
        //виведення по три точки, що утворюють трикутник в річтекстбокс 
        //тобто виводимо інформацію про отримані трикутники
        public void ShowAllTriangles(List<List<Point>>trianglesWithoutPoints)
        {
            for (int i = 0; i < trianglesWithoutPoints.Count; i++)
            {
                for (int j = 0; j < trianglesWithoutPoints[i].Count; j++)
                {
                    pointInside.Text += trianglesWithoutPoints[i][j].X.ToString() + "," + trianglesWithoutPoints[i][j].Y.ToString()+"\n";
                }
                pointInside.Text += "\n";
            }
        }
        //функція, запозичена з тріангуляції
        //визнача чи є всередині трикутника , сформованого з трьох точок, наша точка point
        //тобто ми перевіряємо всі трикутники, чи не знаходиться наша точка всередині
        public bool PointInTriangle(List<Point> triangle,Point point)
        {
            var s = triangle[0].Y * triangle[2].X - triangle[0].X * triangle[2].Y + (triangle[2].Y - triangle[0].Y) * point.X + 
				(triangle[0].X - triangle[2].X) * point.Y;
            var t = triangle[0].X * triangle[1].Y - triangle[0].Y * triangle[1].X + (triangle[0].Y - triangle[1].Y) * point.X + 
				(triangle[1].X - triangle[0].X) * point.Y;

            if ((s < 0) != (t < 0))
                return false;
               
            var A = -triangle[1].Y * triangle[2].X + triangle[0].Y * (triangle[2].X - triangle[1].X) + triangle[0].X * 
				(triangle[1].Y - triangle[2].Y) + triangle[1].X * triangle[2].Y;

            return  A < 0 ? (s <= 0 && s + t >= A) : (s >= 0 && s + t <= A);
     
        }
        //знаходження трикутників без точок всередині( власне тих,які ми шукаємо з умови лр)
        private void TrianglesWithoutPointInside(Point point)
        {
            byte isVertex = 1;
            for (int i = 0; i < trianglesList.Count; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    //
                    if (trianglesList[i][j].X != point.X && trianglesList[i][j].Y != point.Y)
                        isVertex *= 1;
                    else isVertex *= 0;
                }
                if (isVertex==1) //якщо наш прапорець спрацював, точок всередині немає
                {  
                    if (!PointInTriangle(trianglesList[i], point))
                    {//додаємо в список трик без точок всередині
                        trianglesWithoutPoints.Add(trianglesList[i]);
                    }
                }
                isVertex = 1;
            }
           
        }
        //додаємо всі утворені нами трикутники в список
        public void AddAllTrianglesToTheList()
        {
            //якщо точок більше 2, ми можемо намалювати для початку хоч лінії, з яких ми  будемо робити трикутники
            if (points.Count>2)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    for (int j = i + 1; j < points.Count; j++)
                    {
                        for (int k = j + 1; k < points.Count; k++)
                        {
                            //створюємо всеможливі трикутники по три точки і додаємо список точок, що відповідає трикутнику в список трикутників
                            List<Point> newTriangle = new List<Point>();
                            newTriangle.Add(points[i]);
                            newTriangle.Add(points[j]);
                            newTriangle.Add(points[k]);
                            trianglesList.Add(newTriangle);
                        }
                    }
                }
            }
            
        }
        //функція для отримання позиції миші
        //
        private void GetMousePos(object sender, MouseEventArgs e)
        {
            xOffset = Location.X + canvas.Location.X + 12;
            yOffset = Location.Y + canvas.Location.Y + 35;
            mousePos.Text = (Cursor.Position.X-xOffset).ToString()+","+(Cursor.Position.Y-yOffset).ToString();
        }
        private void MarkPoint(Point point)
        {//текст на лейблах над точками, який показує координати точки на панелі рисування
            marks[index].Text = "(" + point.X.ToString() + ";" + point.Y.ToString() + ")";
            marks[index].Location = new Point(point.X, point.Y+10);
            
            index++;
        }

        private void NumOfPoints_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
