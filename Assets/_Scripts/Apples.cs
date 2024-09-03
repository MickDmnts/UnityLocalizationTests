using System;
using UnityEngine;

///<summary>Marks the following field as a label.</summary>
[AttributeUsage(AttributeTargets.Field)]
public sealed class Label : Attribute
{
    ///<summary>The widget label name</summary>
    public string WidgetLabel { get; }

    ///<summary>Marks the following field as a label.</summary>
    public Label(string _widgetName)
    {
        WidgetLabel = _widgetName;
    }
}

public class Apples : MonoBehaviour
{
    public const string txt = "{0}";

    [Label(txt)]
    public int appleCount = 1;

    void Update()
    {
        Label label = (Label)Attribute.GetCustomAttribute(GetType().GetField("appleCount"), typeof(Label));
        Debug.Log(label.WidgetLabel);
    }

    string Hi()
    {
        return appleCount.ToString();
    }
}