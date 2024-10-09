namespace  colas
{
    

    class Cola<T>
        {
            public Nodo<T> primero;
            public Nodo<T> ultimo;

            public Cola()
            {
                primero = null;
                ultimo = null;
            }


            public void Encolar(T valor)
            {
                Nodo<T> nuevoNodo = new Nodo<T>();
                nuevoNodo.info = valor;
                nuevoNodo.siguiente = null;

                if (primero == null)
                {
                    primero = nuevoNodo;
                    ultimo = nuevoNodo;
                }
                else
                {
                    ultimo.siguiente = nuevoNodo;
                    ultimo = nuevoNodo;
                }
            }


            public void Desencolar()
            {
                if (primero == null)
                {
                    Console.WriteLine("Cola vacía");
                }
                else
                {
                    primero = primero.siguiente;


                    if (primero == null)
                    {
                        ultimo = null;
                    }
                }
            }


            public void Mostrar()
            {
                if (primero == null)
                {
                    Console.WriteLine("Cola vacía");
                }
                else
                {
                    Nodo<T> puntero = primero;
                    while (puntero != null)
                    {
                        Console.WriteLine($"{puntero.info}");
                        puntero = puntero.siguiente;
                    }
                }


            }
            public T acceder(int indx)
            {
                Nodo<T> puntero = ultimo;
                int i = 0;
                while (puntero != null&& i< indx)
                {
                    puntero = puntero.siguiente;
                    i++;
                }
                if (puntero != null)
                {
                    return puntero.info;
                }
                else return default(T);

            }

        }
}