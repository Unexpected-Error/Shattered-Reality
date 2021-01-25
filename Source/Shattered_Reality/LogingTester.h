// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "LogingTester.generated.h"

/**
 * 
 */
UCLASS()
class SHATTERED_REALITY_API ULogingTester : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()
		UFUNCTION(BlueprintCallable)
		static void LogErrorText(const FString text);
		UFUNCTION(BlueprintCallable)
		static void LogWarningText(const FString text);
	
};
