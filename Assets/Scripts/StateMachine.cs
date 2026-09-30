using UnityEngine;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private float energy = 100;
    [SerializeField] private float boredom = 100;
    [SerializeField] private float repair = 100;

    [SerializeField] private float energyPerMinute = 10;
    [SerializeField] private float boredomPerMinute = 10;

    public void Play()
    {

    }

    public void Repair(float amount)
    {
        repair += repair;
    }

    public void Charge(float amount)
    {
        energy += amount;
    }

    public void CheckState()
    {
        // energy
        if (energy < 40)
        {
            if (energy <= 0)
            {
                CheckExtremeState();
                return;
            }
            else
            {

            }
        }
        else
        {
            if (repair < 60)
            {

            }
            else
            {
                CheckExtremeState();
                return;
            }
        }

        // boredom
        if (boredom < 40)
        {
            if (boredom <= 0)
            {
                CheckExtremeState();
                return;
            }
            else
            {

            }

        }
        else
        {
            if (repair < 60)
            {

            }
            else
            {
                CheckExtremeState();
                return;
            }
        }

        // repair
        if (repair < 40)
        {
            if (repair <= 0)
            {
                CheckExtremeState();
                return;
            }
            else
            {

            }

        }
        else
        {
            if (repair < 60)
            {

            }
            else
            {
                CheckExtremeState();
                return;
            }
        }
    }

    private void CheckExtremeState()
    {

    }

    private void Update()
    {
        if (energy >= 0 || energy < 100)
            energy -= energyPerMinute * Time.deltaTime / 60;

        if (boredom >= 0 || boredom < 100)
            boredom -= boredomPerMinute * Time.deltaTime / 60;
    }
}
