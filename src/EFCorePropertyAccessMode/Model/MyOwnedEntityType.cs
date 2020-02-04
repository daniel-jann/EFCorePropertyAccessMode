using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace EFCorePropertyAccessMode.Model
{
  public class MyOwnedEntityType
  {
    public MyOwnedEntityType()
    {
    }

    public MyOwnedEntityType(decimal myOwnedEntityTypeField1, string myOwnedEntityTypeField2)
    {
      MyOwnedEntityOwnedEntityTypeField1 = myOwnedEntityTypeField1;
      MyOwnedEntityOwnedEntityTypeField2 = myOwnedEntityTypeField2;
    }

    public decimal MyOwnedEntityOwnedEntityTypeField1 { get; [UsedImplicitly] private set; }
    public string MyOwnedEntityOwnedEntityTypeField2 { get; [UsedImplicitly] private set; }
  }
}