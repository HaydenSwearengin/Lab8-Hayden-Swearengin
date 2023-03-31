public class Circles {
    private double _radius = 0;
    public double Circle(double radius){
        _radius = radius;
        return radius; 
    }

    public double GetRadius(){
        return _radius;
    }

    public void SetRadius(double radius){
        radius = _radius;
    }

    public double GetDiameter(){
        return _radius * 2;
    }

    public double GetCircumference(){
        return 2 * Math.PI * _radius;
    }

    public double GetArea(){
        return Math.PI * (_radius * _radius);
    }
}