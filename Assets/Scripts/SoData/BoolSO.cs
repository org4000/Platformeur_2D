using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class BoolSO : ScriptableObject
{

    [SerializeField] private bool _PowerFrag1;
    [SerializeField] private bool _PowerFrag2;






    public bool Score
    {
        get { return _PowerFrag1; }
        set { _PowerFrag1 = value; }
    }

    public bool KeyFragment
    {
        get { return _PowerFrag2; }
        set { _PowerFrag2 = value; }
    }

   


}
