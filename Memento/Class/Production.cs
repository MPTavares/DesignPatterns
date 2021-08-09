using System;

namespace Memento.Class
{
    public class Production
    {
        public string Name { get; private set; }
        public bool IsActive { get; private set; }

        public Production(string name,bool isActive)
        {
            this.Name = name;
            this.IsActive = isActive;
        }
        public State GetState()
        {
            return new State
            {
                Name = this.Name,
                IsActive = this.IsActive,
                DateState = DateTime.Now
            };
        }
        public void ShowState()
        {
            Console.WriteLine($"Name is {this.Name} and in this momento is active: {this.IsActive}");
        }

        public void RestoreState(State state)
        {
            this.Name = state.Name;
            this.IsActive = state.IsActive;
        }

        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetActive(bool isActive)
        {
            this.IsActive = isActive;
        }
    }
}