string s = "1";


int k = 1, l = 5, m = 3;
bool durum = k < l && k > m;
durum = "a" == "a" && "b" == "d";
durum = "a" == "a" && "b" != "d";
durum = "1" == s && k == l;



durum = k < l || k > m;
durum = "a" == "b" || "b" != "d";
durum = "a" == "a" || "b" != "d";
durum = "1" == s || k == l;