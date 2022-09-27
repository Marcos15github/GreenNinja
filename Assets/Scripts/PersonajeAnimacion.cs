using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeAnimacion : MonoBehaviour
{

    private Animator _animator;
    private PersonajeMovimiento _personajeMovimiento;

    private void Awake ()
    {
        _animator = GetComponent<Animator>();
        _personajeMovimiento = GetComponent<PersonajeMovimiento>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_personajeMovimiento.EnMovimiento == false)
        {
            return; 
        }
        _animator.SetFloat("x", _personajeMovimiento.DireccionMovimiento.x);
         _animator.SetFloat("y", _personajeMovimiento.DireccionMovimiento.y);
    }
}
