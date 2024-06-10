using System;
using static System.Console;
namespace Exercise02{
   
    public abstract class shape{
        public double Height { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }
    }    
    public class Rectangle: shape{
        Rectangle(){
            Height=default;   
            Width=default;
        }
        public Rectangle(double h,double w){
            Height=h;   
            Width=w;
            Area=Height*Width;
        }
    }
    public class Square: shape{
        Square(){
            Height=default;   
            Width=default;
        }
        public Square(double h){
            Height=h;   
            Width=h;
            Area=Height*Width;
        }
    }
    public class Circle: shape{
        Circle(){
            Height=default;   
            Width=default;
        }
        public Circle(double r){
            Height=2*r;   
            Width=2*r;
            Area=Math.PI*r*r;
        }
    }
    class program{
        static void Main(string[] args){
            var r = new Rectangle(3, 4.5);
            WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area: {r.Area}");
            var s = new Square(5);
            WriteLine($"Square H: {s.Height}, W: {s.Width}, Area: {s.Area}");
            var c = new Circle(2.5);
            WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area: {c.Area}");
        }
    }
}