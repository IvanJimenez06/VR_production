using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public GameObject button; // Asigna el botón en el Inspector

    private void Start()
    {
        // Asegúrate de que el botón esté asignado
        if (button != null)
        {
            // Obtén el componente Button y agrega un listener para el clic
            UnityEngine.UI.Button btn = button.GetComponent<UnityEngine.UI.Button>();
            if (btn != null)
            {
                btn.onClick.AddListener(CreateCube);
            }
        }
    }

    void CreateCube()
    {
        // Crea un cubo
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);

        // Establece la posición del cubo
        cube.transform.position = new Vector3(0, 0, 0);

        // Cambia el color del cubo a azul
        Renderer renderer = cube.GetComponent<Renderer>();
        renderer.material.color = Color.blue;
    }
}
