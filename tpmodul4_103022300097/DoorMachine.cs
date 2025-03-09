using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300052
{
    class DoorMachine

    {
        private enum State { Terkunci, Terbuka }
        private State currentState;

        public DoorMachine()
        {
            currentState = State.Terkunci;
            TampilkanState();
        }

        public void BukaPintu()
        {
            if (currentState == State.Terkunci)
            {
                currentState = State.Terbuka;
                TampilkanState();
            }
            else
            {
                Console.WriteLine("Pintu sudah terbuka.\n");
            }
        }

        public void KunciPintu()
        {
            if (currentState == State.Terbuka)
            {
                currentState = State.Terkunci;
                TampilkanState();
            }
            else
            {
                Console.WriteLine("Pintu sudah terkunci.\n");
            }
        }

        private void TampilkanState()
        {
            Console.WriteLine($"\nState masuk: {currentState}");
            if (currentState == State.Terkunci)
            {
                Console.WriteLine("Pintu terkunci\n");
            }
            else
            {
                Console.WriteLine("Pintu tidak terkunci\n");
            }
        }
    }
}
