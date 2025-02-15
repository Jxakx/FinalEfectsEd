using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostProcessControl : MonoBehaviour
{
    [SerializeField] private Material _PPInkMaterial;
    [SerializeField] private bool _IsOnInk;

    [SerializeField] private Material _PPStarMaterial;
    [SerializeField] private bool _IsOnStar;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            TurnOnOffInk();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            TurnOnOffStar();
        }
    }

    public void TurnOnOffInk()
    {
        if (_IsOnInk)
        {
            _PPInkMaterial.SetFloat("_Alpha", 0f);
            
            _IsOnInk = false;
        }
        else
        {
            _PPInkMaterial.SetFloat("_Alpha", 1);
            _IsOnInk = true;
        }
    }

    public void TurnOnOffStar()
    {
        if (_IsOnStar)
        {
            _PPStarMaterial.SetFloat("_Alpha", 0f);

            _IsOnStar = false;
        }
        else
        {
            _PPStarMaterial.SetFloat("_Alpha", 1);
            _IsOnStar = true;
        }
    }
}
