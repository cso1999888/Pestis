using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    #region Data
    [Tooltip("攻擊力")]
    public int ATK = 10;
    [Tooltip("防禦力")]
    public int DEF = 10;
    [Tooltip("血量")]
    public int HP = 1000;
    [Tooltip("魔力")]
    public int MP = 300;
    [Tooltip("技能一")]
    public string SkillOne = "火";
    [Tooltip("技能一消耗魔力")]
    public int SkillOneMp = 50;
    [Tooltip("技能二")]
    public string SkillTwo = "水";
    [Tooltip("技能二消耗魔力")]
    public int SkillTwoMp = 50;
    bool Death;
    [Tooltip("移動速度")]
    public int MS = 5;
    #endregion
    #region Methods
    void Move()
    {
        print("move");
    }
    void CastSkillOne()
    {

    }
    void CastSkillTwo()
    {

    }
    void Hit()
    {

    }
    void Die()
    {

    }
    void Attack()
    {

    }
    #endregion



    // Start is called before the first frame update
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
