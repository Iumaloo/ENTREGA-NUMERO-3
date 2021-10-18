#include <stdio.h>
#include <stdlib.h>
#include "cat.h"
#include "dog.h"

int main(int argc, char const *argv[])
{
	Cat* hopkins = CAT_create("Hopkins");
	Dog* alfred = DOG_create("Alfred");

	// Suscripción al evento SPEAK
	alfred->smell(alfred, hopkins);


	// Publicación del evento 
	hopkins->speak(hopkins);


	hopkins->destroy(hopkins);
	alfred->destroy(alfred);

	return EXIT_SUCCESS;
}

