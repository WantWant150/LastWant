using Microsoft.AspNetCore.Mvc;
using prjCoreWantMember.ViewModels;
using prjCoreWebWantWant.Models;

namespace prjCoreWantMember.Controllers
{
    public class ExpertController : Controller
    {
        public IActionResult ExpertMainPage(CKeywordViewModel vm)
        {
            NewIspanProjectContext db = new NewIspanProjectContext();
            
            IEnumerable<TaskList> datas = null;
            if (string.IsNullOrEmpty(vm.txtKeyword))
            {
                datas = from t in db.TaskLists
                        where t.PublishOrNot == "立刻上架"
                        select t;

            }
            else
            {
                
                datas = db.TaskLists.Where(t => t.TaskTitle.ToUpper().Contains(vm.txtKeyword.ToUpper()) && t.PublishOrNot == "立刻上架" ||
                 t.TaskDetail.ToUpper().Contains(vm.txtKeyword.ToUpper()) && t.PublishOrNot == "立刻上架" ||
                 t.Address.ToUpper().Contains(vm.txtKeyword.ToUpper()) && t.PublishOrNot == "立刻上架"
                );
            }
            return View(datas);
        }
    }

    
}
