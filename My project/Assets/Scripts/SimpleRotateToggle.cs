using UnityEngine;

public class SimpleRotateToggle : MonoBehaviour
{
    private bool mRotationState = true; // Esta variável mantém o controle do estado da rotação (se ele está desligada ou ligada);
    public float Degrees = 100f;
    void Update () {
        if (mRotationState) {
            // se o estado é 1, gire
            transform.Rotate (0f, Degrees * Time.deltaTime, 0f);
        }
    }
    void OnMouseDown () {
        mRotationState = !mRotationState;
        print("State = " + mRotationState);
    }
}
