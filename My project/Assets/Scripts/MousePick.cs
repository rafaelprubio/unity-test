using UnityEngine;

public class MousePick : MonoBehaviour
{
    private int mPicks = 0;
    void OnMouseDown()
    {
        ++mPicks; // Incrementa o número de vezes que o objeto foi escolhido
        print("Este objeto foi escolhido " + mPicks + " vezes.");
    }
}
