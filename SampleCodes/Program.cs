int a = 10;
int i = 0;
int a2 = a;
int m = 6;
int n = 4;
// a = a + b + c
bool cando = false;

while(true) {
	++i;
	if(i > 10) {
		break;
	}
	if(i==5 || i == 8) {
		m--;
		cando = true;
	}
	if(i==2) {
		n--;
		cando = true;
	}
	if(i==10) {
		m +=2;
		n += 5;
		cando = true;
	}
	if(cando) {
		a = a2 + (n * 2) + (m * 3);
		cando = false;
	}
	Console.WriteLine(a);
}