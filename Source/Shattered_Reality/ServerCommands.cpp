// Fill out your copyright notice in the Description page of Project Settings.


#include "ServerCommands.h"

void UServerCommands::Shutdown()
{
	GIsRequestingExit = true;
}
