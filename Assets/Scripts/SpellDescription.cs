using UnityEngine;

[CreateAssetMenu]
public class SpellDescription : ScriptableObject
{
    [Header("Spell Description")]
    public string SpellName;

    [TextArea(5,10)]
    public string Description;

    public Sprite SpellIcon;

    public float Duration;
    public float Cooldown;
    public string AnimationVariableName;
}
