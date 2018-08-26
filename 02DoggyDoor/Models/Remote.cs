using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02DoggyDoor.Models
{
    public class Remote
    {
        private DogDoor door;

        private CancellationTokenSource tokenSource;
        private CancellationToken token;

        public Remote(DogDoor door)
        {
            this.door = door;
            tokenSource = new CancellationTokenSource();
            token = tokenSource.Token;
        }

        public void PressButton()
        {
            Console.WriteLine("Pressing the remote control button...");
            if (door.IsOpen)
            {
                if (token.CanBeCanceled)
                {
                    tokenSource.Cancel();
                }
                door.Close();
            }
            else
            {
                door.Open();

                Task doorAutoClose = Task.Run(async () =>
                {
                    await Task.Delay(5000);
                    Console.WriteLine("AUTOMATICALLY performing the following action:");
                    door.Close();
                }, token);
            }
        }
    }
}
