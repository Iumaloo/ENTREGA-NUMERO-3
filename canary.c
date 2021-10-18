#include "canary.h"

//DESTRUIR PÀJARO
static void _destroy(Canary* this)
{
	this->observer->destroy(this->observer);

	if (this != NULL){
		free(this);
		this = NULL;
	}
}

//MÈTODO "SEE" (VER)
static void _see(Canary * this, Cat* cat)
{
	cat->registerObserver(cat, this->observer);
	printf("%s Just saw %s\n", this->name, cat->name);
}

//PARA ACCEDER AL MÈTODO DEL MICHI
static void _handleCatEvent(Canary* this, Cat* cat)
{
	printf("%s\n just heard %s\n", this->name, cat->name); //notificaciòn al pajarraco que ya escuchò al michi
}

static void _notify(Canary* this, int numero, void* subject) {
	_handleCatEvent(this, (Cat*) subject);
}

Canary* CANARY_create(char* canaryName)
{
	Canary* this = (Canary*) malloc(sizeof(*this));

	this->name = canaryName;
	this->see = _see;
	this->destroy = _destroy;
	this->observer = observerNew(this, (void (*)(void*, int, void*))_notify);

	return this;
}