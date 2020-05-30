using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil Water", Platform = "Kettle and Pan" },
                new Command { Id = 1, HowTo = "Cut Bread", Line = "Get Knife", Platform = "Knife and Chopping board" },
                new Command { Id = 2, HowTo = "Make Coffee", Line = "Place coffer in filter", Platform = "Coffee maker" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil and egg", Line = "Boil Water", Platform = "Kettle and Pan" };
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}