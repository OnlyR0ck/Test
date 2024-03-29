﻿using System;
using System.Collections.Generic;

namespace TestTask.Computer.SystemUnit
{
    public class AsusZ170ProGaming : MotherBoardBase
    {
        private Dictionary<Type, IMotherBoardComponent> components;

        public AsusZ170ProGaming()
        {
            components = new Dictionary<Type, IMotherBoardComponent>()
            {
                
            };
        }

        public override bool CheckComponents() => new Random().Next(0, 10) > 5;

        public override void AddComponent<TComponent>(IMotherBoardComponent component) =>
            components.Add(typeof(TComponent), component);
    }

    public interface IMotherBoardComponent
    {
    }
}