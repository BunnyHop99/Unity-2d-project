using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Message", order = 1, menuName = "Advices/Warning")]
public class WarningMessage : ScriptableObject
{
    [SerializeField, TextArea(5,10), Tooltip("Message for advice object")]

    string message;

    public string Message => message;
}
