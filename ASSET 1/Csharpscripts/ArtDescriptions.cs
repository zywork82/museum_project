using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ArtDescriptions : MonoBehaviour
//NOTE MAX WORD LIMIT 180
{
   public TMP_Text dText;

    public void ChangeDescTheAmbassadors()
    {
        dText.text = "Jean de Dinteville, the man on the left, is shown on his second diplomatic mission to England on behalf of Francis I, King of France. To the right is his close friend, Georges de Selve, Bishop of Lavaur. This portrait was painted at a time of religious upheaval in Europe. Although the pope had refused to annul Henry VIII, King of England’s marriage to Catherine of Aragon which resulted in a break with the Roman Catholic Church, in 1533 he married Anne Boleyn. The array of objects on the table seem to allude to discord; the arithmetic book, for example, is open at the page concerning mathematical division.The portrait is a supreme display of Holbein’s skill in composing images and in manipulating oil paint to recreate a variety of textures. If viewed from a particular angle the elongated shape between the men’s feet becomes a skull. Equally hidden at the top left of the picture is a crucifix that hints at the hope of redemption in the resurrected Christ.";
    }
    public void ChangeDescJudith()
    {
        dText.text = "The canvas shows Judith beheading Holofernes. The subject takes an episode from the apocryphal Book of Judith in the Old Testament, which recounts the assassination of the Assyrian general Holofernes by the Israelite heroine Judith. The painting shows the moment when Judith, helped by her maidservant Abra, beheads the general after he has fallen asleep in a drunken stupor. She painted a second version now in the Uffizi, Florence, somewhere between 1613 and 1621.Early feminist critics interpreted the painting as a form of visual revenge following Gentileschi's rape by Agostino Tassi in 1611; similarly many other art historians see the painting in the context of her achievement in portraying strong women.";
    }
    public void ChangeDescPearlGirl()
    {
        dText.text = "Nicknamed the 'Mona Lisa of the North', this beautiful painting - one of the most famous Baroque portraits - shows that, in addition to his mastery of Dutch Realist genre painting, Vermeer was also a master portraitist. His skill in painting the heads of young women is well known from works like Head of a Girl (1672, Metropolitan Museum), The Milkmaid (1658, Rijksmuseum), Lady Writing a Letter (c.1665-70) and Girl with a Red Hat (1666) both in the National Gallery of Art, Washington DC., but for sheer impact Girl with a Pearl Earring ranks alongside works by the best portrait artists in Holland such as Rembrandt (1606-69) and Van Dyck (1599-1641). In fact, technically speaking, this well known picture - known also as Head of a Girl with a Turban - is not a portrait but a study of a girl's head, known in Vermeer's day as a 'tronie'.  ";
    }

}
