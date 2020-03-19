using System.Collections.Generic;
using DapperAndDocker.Models;

namespace DapperAndDocker.Services.Items
{
    public interface IItemRepository
    {
        List<ItemModel> GetList();
    }
}