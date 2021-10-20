#pragma once
#ifndef INC_PLUGIN01_H_
#define INC_PLUGIN01_H_
#include <cstdint>

#define STDCALL
#define DLLEXPORT __declspec(dllexport)

extern "C"
{
    DLLEXPORT int32_t STDCALL get_value();
}
#endif //INC_PLUGIN01_H_

