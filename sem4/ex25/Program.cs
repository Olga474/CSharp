int deg(int a, int b) {
int a1 = a;
for (int i = 1; i < b; i++) {
    a = a1*a;
}
return a;
}

int k = deg(2,5);