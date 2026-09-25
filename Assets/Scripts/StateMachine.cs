using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private AbstractState[] states;



    [SerializeField] private int energy;
    [SerializeField] private int boredom;
    [SerializeField] private int repair;

    public void SetState()
    {

    }


}
