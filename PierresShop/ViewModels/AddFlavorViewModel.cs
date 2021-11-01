using System.Collections.Generic;

namespace PierresShop.ViewModels
{
  public class AddFlavorViewModel
  {
    public List<int> SelectedFlavorIds { get; set;}

    public IEnumerable<SelectListItem> FlavorChoices { get; set;}
  }
}




// public class AssetViewModel
// {
//     // any other asset properties you need to edit

//     public List<int> SelectedCategoryIds { get; set; }

//     public IEnumerable<SelectListItem> CategoryChoices { get; set; }
// }