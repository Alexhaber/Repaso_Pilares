namespace Repaso_pilares
{
    public abstract class Calculo
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        protected double n3 { get; set; }

        public abstract double Operacion();

        public override string ToString() => $"{n1}, {n2}, {n3}";
    }
    
    public class Suma: Calculo
    {
        public override double Operacion()
        {
            n3 = n1 + n2;
            return n3;
        }
    }

    public class Resta: Calculo
    {
        public override double Operacion()
        {
            n3 = n1 - n2;
            return n3;
        }
    }

    public class Mult: Calculo
    {
        public override double Operacion()
        {
            n3 = n1 + n2;
            return n3;
        }
    }
}
