namespace Logic
{
    public class PalindromeChecker
    {
        public bool Check(string strToCheck)
        {
            for (int right = 0, left = strToCheck.Length - 1; ;)
            {
                if (!IsAlphaNumeric(strToCheck[right]))
                {
                    right++;
                    continue;
                }

                if (!IsAlphaNumeric(strToCheck[left]))
                {
                    left--;
                    continue;
                }

                if (!IsCharsEquals(strToCheck[right], strToCheck[left]))
                    return false;

                if (right > left)
                    return true;

                right++;
                left--;
            }
        }

        private bool IsCharsEquals(char c1, char c2) => char.ToLower(c1) == char.ToLower(c2);

        private bool IsAlphaNumeric(char charToCheck) => char.IsLetter(charToCheck) || char.IsDigit(charToCheck);

    }
}
