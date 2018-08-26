using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C04BarkType.Models
{
    public class DogDoor
    {
        private bool isOpen;
        public bool IsOpen => isOpen;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;

        public DogDoor()
        {
            isOpen = false;
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
        }

        public void Open()
        {
            Console.WriteLine("The dog door opens.");
            isOpen = true;

            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
            Task doorAutoClose = Task.Run(async () => {
                await Task.Delay(5000);
                Console.Write("The door was left open, AUTOMATICALLY doing: ");
                Close();
            }, token);
        }

        public void Close()
        {
            if (token.CanBeCanceled)
            {
                tokenSource.Cancel();
            }
            Console.WriteLine("The dog door closes.");
            isOpen = false;
        }

    }
}
