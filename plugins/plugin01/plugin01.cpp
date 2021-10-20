#include "plugin01.h"

extern "C"
{
    DLLEXPORT int32_t STDCALL get_value()
    {
        return 4201;
    }
}

