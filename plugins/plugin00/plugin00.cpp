#include "plugin00.h"

extern "C"
{
    DLLEXPORT int32_t STDCALL get_value()
    {
        return 4200;
    }
}

