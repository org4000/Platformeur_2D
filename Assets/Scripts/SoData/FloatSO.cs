using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class FloatSO : ScriptableObject
{
	
    [SerializeField] public float _Score;
    [SerializeField] private float _KeyFrag;
    [SerializeField] private float _CurrentHealth;



	public float Score
	{
		get { return _Score; }
		set { _Score = value; }
	}

    public float KeyFragment
    {
        get { return _KeyFrag; }
        set { _KeyFrag = value; }
    }

	public float CurrentHealth
	{
		get { return _CurrentHealth; }
		set { _CurrentHealth = value; }
	}


}
