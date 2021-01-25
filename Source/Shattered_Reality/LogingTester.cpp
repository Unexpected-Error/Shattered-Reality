// Fill out your copyright notice in the Description page of Project Settings.


#include "LogingTester.h"

void ULogingTester::LogErrorText(const FString text) {
	UE_LOG(LogTemp,Error,TEXT("%s"), *text)
}
void ULogingTester::LogWarningText(const FString text) {
	UE_LOG(LogTemp, Warning, TEXT("%s"), *text)
}