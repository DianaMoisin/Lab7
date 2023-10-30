using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex1 POS

            bool cardClasic = false;
            bool carduriContactless = false;
            bool telefoaneMobileContactless = false;

            double sumaDeplata = 0;

            IContactless contactless = new ContactlessClass();
            IContactFull contactFull = new ContactFullClass();

            if (cardClasic)
            {
                contactFull.PlataContactFull(sumaDeplata, contactFull);
            }

            if (carduriContactless)
            {
                contactFull.PlataContactFull(sumaDeplata, contactFull);
                contactless.PlataContactless(sumaDeplata, contactless);
            }

            if (telefoaneMobileContactless)
            {
                contactless.PlataContactless(sumaDeplata, contactless);
            }

            //ex2  Casa de marcat

            bool cash = false;

            ICash icash = new CashClass();

            if (cash)
            {
                icash.DeschideSeif();
                icash.IntroducereSuma();
                icash.InchideSeif();
                icash.ElibereazaChitanta();
                icash.PlataCash(sumaDeplata);
            }
            else
            {

                if (cardClasic)
                {
                    contactFull.PlataContactFull(sumaDeplata, contactFull);
                }

                if (carduriContactless)
                {
                    contactFull.PlataContactFull(sumaDeplata, contactFull);
                    contactless.PlataContactless(sumaDeplata, contactless);
                }

                if (telefoaneMobileContactless)
                {
                    contactless.PlataContactless(sumaDeplata, contactless);
                }

            }
        }
    }
}
