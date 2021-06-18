using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaHelper.Menu
{
    public static class Menu
    {
        public static MenuItem generateItem(int index, string name, string method)
        {
            MenuItem item = new MenuItem();
            
            item.Index = index;
            item.Name = name;
            item.Method = method;

            return item;
        }

        public static void printMenu(MenuOptionContract option)
        {
            List<MenuItem> items = option.getItems();

            Console.WriteLine(
                "Elija una opcion\n\n"
            );

            foreach (MenuItem item in items)
            {
                Console.WriteLine(
                    "{0} - {1}",
                    item.Index,
                    item.Name
                );
            }

            Console.WriteLine("0 – Exit(Salir del programa) \n");
        }

        public static void getMenu(MenuOptionContract option, MenuItem item)
        {
            Type thisType = option.GetType();
            MethodInfo theMethod = thisType.GetMethod(item.Method);
            theMethod.Invoke(option, null);
        }

        public static void executeMenu(MenuOptionContract option)
        {
            int selectedOption;
            bool volver = true;
            do
            {
                Console.Clear();
                Input.Inicio();
                
                printMenu(option);

                List<MenuItem> items = option.getItems();

                int lastIndex = items.Last().Index;

                selectedOption = Input.IngresoNumeroPositivo(
                    "Ingrese la opcion elegida", 
                    lastIndex
                );

                if(selectedOption == 0)
                {
                    Input.Exit();
                }

                Console.Clear();

                try
                {
                    getMenu(option, items.First(it => it.Index == selectedOption));
                }
                catch (Exception error)
                {
                    throw new MenuOptionException(error.Message);
                }


                Input.Continuar();

            } while (volver);
        }
    }
}
