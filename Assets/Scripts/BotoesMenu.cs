using UnityEngine;
using UnityEngine.SceneManagement;

public class BotoesMenu : MonoBehaviour
{
void Start ()
{

FecharConfig();

}

public string nomeDoFilho = "Configurações";

public void MostrarConfig()
{
Transform filho = transform.Find(nomeDoFilho);
filho.gameObject.SetActive(true);
}

public void FecharConfig()

{
Transform filho = transform.Find(nomeDoFilho);
filho.gameObject.SetActive(false);
}
  public void IniciarJogo()
{
  SceneManager.LoadScene("GameScene");
   }

   public void VoltarAoMenu()
   {
       SceneManager.LoadScene("Menu");
   }

    public void SairDoJogo()
    {
        Application.Quit();
    }
}
