using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i
    {
        get
        {
            if(_i == null) _i = ((GameObject) Instantiate(Resources.Load("GameAssets"))).GetComponent<GameAssets>();
            return _i;
        }
    }

    public GameObject SwordQi;
}