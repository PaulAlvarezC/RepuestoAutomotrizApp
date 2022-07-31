namespace RepuestoAutomotrizApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GeneralCars pedido = new GeneralCars(new AutomotrizBMW());
            
            pedido.CreateRepuestos();
            pedido.realizarProforma();

            GeneralCars pedido2 = new GeneralCars(new AutomotrizJac());

            pedido2.CreateRepuestos();
            pedido2.realizarProforma();

            GeneralCars pedido3 = new GeneralCars(new AutomotrizVolvo());

            pedido3.CreateRepuestos();
            pedido3.realizarProforma();
        }
    }
}