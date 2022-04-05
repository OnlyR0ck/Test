using System;
using System.Collections.Generic;

namespace TestTask.Computer.SystemUnit
{
    public class SystemUnit : ISystemUnit
    {
        private Dictionary<Type, IComponent> components;

        public SystemUnit()
        {
            components = new Dictionary<Type, IComponent>()
            {
                {typeof(AsusZ170ProGaming), new AsusZ170ProGaming()} 
            };
        }

        
        /*
         * Помечу коммент как TODO: Чтобы его легко можно было найти через райдер
         * Функционал для замены комлектующих ПК. Компонент - это один из комплектующих, например
         * материнская плата. Чтобы заменить материнскую плату в пк, нужно будет написать код:
         * ReplaceComponent<IMotherBoard, AsusZProGaming>(motherboard);
         * Почему я выбрал подобное решение?
         * Это позволяет все компоненты хранить в одном месте, а с помощью стратегий подменять
         * реализацию динамически в рантайме.
         * Но заменять материнскую плату во время работы ПК всё же не стоит ^_^
         */
        public void ReplaceComponent<TRole, TNewComponent>(TNewComponent newComponent) where TNewComponent : IComponent
        {
            components[typeof(TRole)] = newComponent;
        }

        public void Power(bool isActive)
        {
            
        }

        public void Reboot(int delay)
        {
            
        }
    }
}