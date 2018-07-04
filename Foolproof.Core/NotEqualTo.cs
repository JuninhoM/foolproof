﻿
namespace Foolproof.Core
{
  public class NotEqualToAttribute : IsAttribute
  {
    public NotEqualToAttribute(string dependentProperty) : base(Operator.NotEqualTo, dependentProperty) { }
  }
}
