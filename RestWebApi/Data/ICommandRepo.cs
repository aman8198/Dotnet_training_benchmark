using RestWebApi.Models;
using System.Collections.Generic;

namespace RestWebApi.Data
{
    public interface ICommandRepo
    {
        bool saveChanges();
        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);

        void CreateCommand(Command cmd);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);

    }

}