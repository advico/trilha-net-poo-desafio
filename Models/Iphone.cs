using System;

namespace DesafioPOO.Models
{
    public class iPhone : Smartphone
    {
        public string TouchID { get; set; }
        public string FaceID { get; set; }

        public iPhone(string numero, string modelo, string imei, int memoria, string touchID, string faceID) 
            : base(numero, modelo, imei, memoria)
        {
            TouchID = touchID;
            FaceID = faceID;
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no iPhone");
        }

        public void DesbloquearComTouchID()
        {
            Console.WriteLine("Desbloqueando com Touch ID...");
        }

        public void DesbloquearComFaceID()
        {
            Console.WriteLine("Desbloqueando com Face ID...");
        }
    }
}
