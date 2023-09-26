string Replace(string text, char OldValue, char newValue) {
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i<length; i++) {
        
        if (text[i] == (OldValue)) {
            result += newValue;
        } else {
            result += text[i];
        }
    }
    return result;
}

string text1 = Replace(text:"– Я думаю, – сказал князь, улыбаясь, – что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?", OldValue:'–', newValue:':');
string text2 = Replace(text1, 'к', 'К');
Console.Write(Replace(text2, '?', '!'));