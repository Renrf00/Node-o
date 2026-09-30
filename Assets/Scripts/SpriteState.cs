using System.Collections;
using System.Linq;
using UnityEngine;

public class SpriteState : MonoBehaviour
{
    [SerializeField] private Sprite[] stateLevels;
    [SerializeField] private Sprite blink;
    private SpriteRenderer renderer;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        if (blink != null)
            StartCoroutine(Blink());
    }

    private IEnumerator Blink()
    {
        Sprite previousSprite = renderer.sprite;
        while (gameObject)
        {
            renderer.sprite = blink;

            yield return new WaitForSeconds(0.1f);

            renderer.sprite = previousSprite;

            yield return new WaitForSeconds(Random.Range(3f, 5f));
        }
    }

    public void ChangeSprite(float stateLevel)
    {
        if (stateLevels.Length != 5) return;

        if (stateLevel <= 0)
        {
            renderer.sprite = stateLevels[0];
        }
        else if (stateLevel < 40)
        {
            renderer.sprite = stateLevels[1];
        }
        else if (stateLevel < 60)
        {
            renderer.sprite = stateLevels[2];
        }
        else if (stateLevel < 90)
        {
            renderer.sprite = stateLevels[3];
        }
        else
        {
            renderer.sprite = stateLevels[4];
        }
    }
}
