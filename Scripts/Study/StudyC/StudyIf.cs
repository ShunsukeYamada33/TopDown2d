using UnityEngine;

public class StudyIf : MonoBehaviour
{
    // If
    // ğŒ•ªŠò

    void Start()
    {
        int int01 = 10;

        // if ( ğŒ true, false )
        // {
        //   ˆ—
        // }

        // ‚à‚µ‚à()‚ª true ‚È‚çˆ—‚ğÀs
        if (int01 > 0)
        {
            // ˆ—
        }

        // else
        // ‚à‚µ‚à()‚ª true ‚È‚çˆ—‡@‚ğÀs
        if (int01 > 1)
        {
            // ˆ—‡@
        }
        // ‚±‚±‚Ü‚Åˆ—‚ªs‚í‚ê‚Ä‚¢‚È‚¯‚ê‚Îˆ—‡A‚ğÀs
        else
        {
            // ˆ—‡A
        }

        // else if
        // ‚à‚µ‚à()‚ª true ‚È‚çˆ—‡@‚ğÀs
        if(int01 > 2)
        {
            // ˆ—‡@
        }
        // ‚à‚µ‚à()‚ª true ‚È‚çˆ—‡A‚ğÀs
        else if (int01 > 3)
        {
            // ˆ—‡A
        }
        // ‚à‚µ‚à()‚ª true ‚È‚çˆ—‡B‚ğÀs
        else if (int01 > 3)
        {
            // ˆ—‡B
        }
        // ‚±‚±‚Ü‚Åˆ—‚ªs‚í‚ê‚Ä‚¢‚È‚¯‚ê‚Îˆ—‡C‚ğÀs
        else
        {
            // ˆ—‡C
        }


        // ã‚©‚çŠm”F‚µ‚Ä‚¢‚«AÅ‰‚É true ‚É‚È‚Á‚½ˆ—‚ğÀs
        // ‚Ç‚ê‚©Å‘åˆê‚Â‚¾‚¯ˆ—‚ğ‚µ‚ÄI—¹


        // ‰—p
        // •¡”‘g‚İ‡‚í‚¹‚ç‚ê‚é‚±‚Æ‚à‚ ‚é‚ªl‚¦•û‚Í“¯‚¶
        if (int01 > 5)
        {
            if (int01 > 6)
            {
                // ˆ—‡@
            }
            else if (int01 > 7)
            {
                // ˆ—‡A
            }

            if (int01 > 4)
            {
                // ˆ—‡B
            }
            else
            {
                // ˆ—‡C
            }
        }
        else if (int01 < 20)
        {
            // ˆ—‡D
        }
    }
}
