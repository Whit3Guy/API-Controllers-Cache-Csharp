using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aprendendo_pizza.models;

namespace aprendendo_pizza.services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas {get;}
        static int nextId = 3;

        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza {id = 1, name = "peperoni",isGlutenFree = true},
                new Pizza {id = 2, name = "pomodoro",isGlutenFree = false},
            };
        }

        public static void Add(Pizza pizza){
            nextId++;
            Pizzas.Add(pizza);
        }

        public static List<Pizza> GetAll() => Pizzas;
        public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.id == id );

        public static void Update(Pizza pizza, int id){
            int index = Pizzas.FindIndex(p => p.id == id);

            if(index is -1){
                return;
            }

            Pizzas[index] = pizza;
        }

        public static void Delete(int id){
            Pizza? pizza = Get(id);
            if(pizza is null){
                return;
            }
             Pizzas.Remove(pizza);
        }


    }
}