using System;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância de Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 64);

            // Testando métodos da classe Nokia
            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            Console.WriteLine();

            // Criando uma instância de iPhone
            iPhone iphone = new iPhone("987654321", "iPhone 12", "987654321098765", 128, "Touch ID", "Face ID");

            // Testando métodos da classe iPhone
            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
            iphone.DesbloquearComTouchID();
            iphone.DesbloquearComFaceID();
        }
    }
}
