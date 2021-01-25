// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "ServerCommands.generated.h"

/**
 * 
 */
UCLASS()
class SHATTERED_REALITY_API UServerCommands : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
		UFUNCTION(BlueprintCallable,meta = (HidePin = "WorldContextObject", DefaultToSelf = "WorldContextObject", Keywords = "Exit"))
		static void Shutdown();
};
