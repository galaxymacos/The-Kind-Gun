using UnityEngine;

public class CharacterData: MonoBehaviour
{
    public static CharacterData Instance;
    
    [SerializeField] private Skill mainSkill;
    [SerializeField] private Skill secondSkill;
    [SerializeField] private Skill normalSkill;

    public Skill MainSkill => mainSkill;

    public Skill SecondSkill => secondSkill;

    public Skill NormalSkill => normalSkill;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    
}