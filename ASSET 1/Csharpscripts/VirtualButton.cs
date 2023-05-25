using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;
using TMPro;

public class VirtualButton : MonoBehaviour
{
   public GameObject canvas;
   public VirtualButtonBehaviour Vb;
   // public TMP_Text targetDesc;
   public TextMeshProUGUI charDesc;
   public UnityEvent OtherFunctions;
   
//button control
   void Start()
   {
    Vb.RegisterOnButtonPressed(OnButtonPressed);
    Vb.RegisterOnButtonReleased(OnButtonReleased);

    canvas.SetActive(false);
   }

   public void OnButtonPressed(VirtualButtonBehaviour vb)
   {
    canvas.SetActive(true);
   }
   public void OnButtonReleased(VirtualButtonBehaviour vb)
   {
    canvas.SetActive(false);
  }

  // MAX WORDS 60
    // The Ambassadors - 3 Characters
    public void ChangeJean()
    {
        charDesc.text = "Jean de Dinteville - He was a French diplomat and nobleman born around 1504. He was a member of the Dinteville family, which held significant political influence in Burgundy, France. Dinteville served as the French ambassador to England during the reign of King Henry VIII.";
        // charDesc.gameObject.SetActive(false);
    }

    public void ChangeGeorges()
    {
        charDesc.text = "Georges de Selve - He  was born in 1508 in Toulouse, France, to a noble family. He received an education in law and became a prominent diplomat and ecclesiastic figure during the Renaissance period. Selve served as a representative of the French crown and held various diplomatic posts throughout his career.";
    }

    public void ChangeSkull()
    {
        charDesc.text = "Momento Mori - Holbein used a grid system to graphically project the image of a skull so that it appears entirely distorted from a frontal perspective, but becomes perfectly proportional when viewed at an oblique angle from the right. It’s an ingenious riff on the memento mori trope, reminding viewers of death amidst life. It rhymes with the more subtle badge in the shape of a skull which is pinned to de Dinteville’s hat.";
    }

    // Girl with a Pearl Earring - 2 Character
    public void ChangeGIRLWithPearlEarring() {
        charDesc.text = "The Girl - the painting is a tronie, a work that isn’t a portrait of a specific person; rather, it’s focused on depicting facial expressions. 'A young woman might have sat for Vermeer,' per Encyclopedia Britannica, 'but the painting is not meant to portray her or any specific individual.' ";
    }
    public void ChangePEARLGirlWithPearlEarring() {
        charDesc.text = "The Pearl - delicately adorns the girl's earlobe, reflecting soft light and symbolizing purity, innocence, and feminine beauty. Its presence enhances her understated elegance, inviting contemplation of hidden desires. Vermeer's brushstrokes capture its exquisite texture, intensifying the painting's enigmatic allure. A silent dialogue beckons to unravel mysteries, where artistry and elegance intertwine.";
    }

    // Judith beheading Holofernes - 3 Characters
    public void ChangeHolofernes() {
        charDesc.text = "Holofernes - was an Assyrian general who was about to destroy Judith's home, the city of Bethulia. Overcome with drink, he passes out and is decapitated by Judith; his head is taken away in a basket (often depicted as being carried by an elderly female servant) ";
    }

    public void ChangeJudith() {
        charDesc.text = "Judith - A Jewish widow who murders an Assyrian general to save her town from invasion.When Holofernes sieges the city of Bethulia, Judith seduces the general and murders him in his sleep. The assassination gives the Israelites the advantage they need to defeat the Assyrians.";
    }

    public void ChangeMaid() {
        charDesc.text = "Abra - The maidservant of Judith, a Jewish widow renowned for her beauty and charm, wraps the severed head of the Assyrian general Holofernes in a bag";
    }    
}
