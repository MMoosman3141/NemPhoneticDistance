using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NemPhoneticDistance {
  internal class Feature {
    private bool _isPositive;
    private bool _isNegative;
    private bool _isSet = false;

    public string Name { get; set; }
    public bool IsPositive {
      get => _isPositive;
      set {
        _isPositive = value;

        if(_isPositive) {
          IsSet = true;
        }
      }
    }
    public bool IsNegative {
      get => _isNegative;
      set {
        _isNegative = value;

        if(_isNegative) {
          IsSet = true;
        }
      }
    }
    public bool IsSet {
      get => _isSet;
      set {
        _isSet = value;

        if(!_isSet) {
          IsPositive = false;
          IsNegative = false;
        }
      }

    }
  }
}
