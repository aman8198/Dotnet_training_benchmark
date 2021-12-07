using System.Collections.Generic;
using RestWebApi.Models;

namespace RestWebApi.Data
{
    public class MockCommandRepo : ICommandRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                 new Command{Id=0, HowTo="Eat food", Line="Is Straight", Platform="kettle and Pen"},
                  new Command{Id=1, HowTo="Loose Weight", Line="Nutrition", Platform="Workout"},
                   new Command{Id=2, HowTo="Enjoy moment", Line="Become Happy", Platform="Live Laugh Love"}

            };
            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Eat food", Line="Is Straight", Platform="kettle and Pen"};
        }

        public bool saveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }

}